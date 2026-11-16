# CIS 351 Project 1 — R code extracted from the original HTML report
# Extracted in original order; not independently executed or verified.
# The report includes third-party/example package loading code.

# ---- Original code chunk 1 ----
library(tidyverse)

# ---- Original code chunk 2 ----
library(janitor)

# ---- Original code chunk 3 ----
library(ucimlrepo)

library(palmerpenguins)

library(gapminder)

library(tidytuesdayR)

library(dplyr)

library(ggplot2)

 library(ggpubr)

# ---- Original code chunk 4 ----
drug_consumption <- fetch_ucirepo(id=373)

cat(drug_consumption$"metadata"$additional_info$summary)

# ---- Original code chunk 5 ----
df_drugs <- drug_consumption$data$original

drugs_summary <- df_drugs |>
  pivot_longer(cols = c(nscore, escore, oscore), names_to = "variable", values_to = "value") |>
  summarize(
    min = round(min(value), 8),
    mean = round(mean(value), 8),
    median = round(median(value), 8),
    max = round(max(value), 8),
    sd = round(sd(value), 8),
    .by = "variable"
  )

drugs_summary

# ---- Original code chunk 6 ----
alc_cat_summary <- df_drugs |> 
  select(alcohol) |>
  summarize(
    Count = n(),
    .by = alcohol
  ) |>
  mutate(
    Percent = round((Count / sum(Count)) * 100, 2)
  ) |>
  arrange(desc(Count))


nic_cat_summary <- df_drugs |> 
  select(nicotine) |>
  summarize(
    Count = n(),
    .by = nicotine
  ) |>
  mutate(
    Percent = round((Count / sum(Count)) * 100, 2)
  ) |>
  arrange(desc(Count))


can_cat_summary <- df_drugs |> 
  select(cannabis) |>
  summarize(
    Count = n(),
    .by = cannabis
  ) |>
  mutate(
    Percent = round((Count / sum(Count)) * 100, 2)
  ) |>
  arrange(desc(Count))

alc_cat_summary

# ---- Original code chunk 7 ----
nic_cat_summary

# ---- Original code chunk 8 ----
can_cat_summary

# ---- Original code chunk 9 ----
alc_groups_summary <- df_drugs |>
  group_by(alcohol) |>
  summarize(
    across(c(nscore, escore, oscore),
           list(
             min = min,
             mean = mean,
             median = median,
             max = max,
             sd = sd
           )
    )
  ) |>
  ungroup()

alc_groups_summary

# ---- Original code chunk 10 ----
nic_groups_summary <- df_drugs |>
group_by(nicotine) |>
summarize(
    across(c(nscore, escore, oscore), 
           list(
             min = min,
             mean = mean,
             median = median,
             max = max,
             sd = sd
           )
    )
  ) |>
  ungroup()

nic_groups_summary

# ---- Original code chunk 11 ----
alcohol_scatter <- df_drugs |> 
 ggscatter(
    x = 'escore',
    y = 'nscore',
    add = 'reg.line',  #regression line 
    add.params = list(
    color = 'blue'
    )
  ) + 
  stat_cor(
    label.x = -4,
    label.y = 5
  ) +
  stat_regline_equation(
    label.x = -4, 
    label.y = 4 #Bottom of the x, top of the y based on the regression line
  ) +
  scale_y_continuous(
    limits = c(-4,5)
  )


alcohol_scatter

# ---- Original code chunk 12 ----
box_ascore <- df_drugs |> 
  ggplot(
    aes(
      x = alcohol,
      y = ascore,
      fill = alcohol
    )
  ) +
  geom_boxplot() +
  theme_bw()


box_ascore

# ---- Original code chunk 13 ----
#3. Create two stacked barplots of two distinct categorical variables. One is stacked by count, the other by proportion. (04/11/2025)

df_drugs_1 <- df_drugs |> 
  mutate(
    use = case_when(
      alcohol == 'CL0' ~ 'Few',
      alcohol == 'CL1' ~ 'Few',
      alcohol == 'CL2' ~ 'Few',
      alcohol == 'CL3' ~ 'Few',
      alcohol == 'CL4' ~ 'Often',
      alcohol == 'CL5' ~ 'Often',
      alcohol == 'CL6' ~ 'Often'
    ) 
) 
 df_drugs_1 |> 
    ggplot(
    aes(
      x = choc,
      fill = use
    )
  ) +
  geom_bar() +
  theme_bw() +
  labs(
    x = 'Chocolate Use',
    y = 'Count',
    fill = 'Alcohol use' )

# ---- Original code chunk 14 ----
df_drugs_1 |> 
  ggplot(
    aes(
      x = nicotine,
      fill = use
    )
  ) + 
  geom_bar(position = 'fill') +
  theme_bw() +
  labs(
    x = 'Nicotine',
    y = 'Proporiton'
  )

# ---- Original code chunk 15 ----
test_1 <- chisq.test(
  table(
    df_drugs$choc,
    df_drugs$nicotine
  )
)

# ---- Original code chunk 16 ----
test_1

# ---- Original code chunk 17 ----
oneway.test(
  ascore ~ alcohol,
  data = df_drugs,
  var.equal = TRUE 
)

