<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryPointActionAutoAssignRuleResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryPointActionAutoAssignRuleResponseBody\result\queryPointRuleResponseDTOS;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 行为规则列表
     *
     * @var queryPointRuleResponseDTOS[]
     */
    public $queryPointRuleResponseDTOS;
    protected $_name = [
        'queryPointRuleResponseDTOS' => 'queryPointRuleResponseDTOS',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->queryPointRuleResponseDTOS) {
            $res['queryPointRuleResponseDTOS'] = [];
            if (null !== $this->queryPointRuleResponseDTOS && \is_array($this->queryPointRuleResponseDTOS)) {
                $n = 0;
                foreach ($this->queryPointRuleResponseDTOS as $item) {
                    $res['queryPointRuleResponseDTOS'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['queryPointRuleResponseDTOS'])) {
            if (!empty($map['queryPointRuleResponseDTOS'])) {
                $model->queryPointRuleResponseDTOS = [];
                $n                                 = 0;
                foreach ($map['queryPointRuleResponseDTOS'] as $item) {
                    $model->queryPointRuleResponseDTOS[$n++] = null !== $item ? queryPointRuleResponseDTOS::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
