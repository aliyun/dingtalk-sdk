<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignByCodeResponseBody\approvalSummary;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignByCodeResponseBody\flowConfig;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignByCodeResponseBody\formulaRules;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignByCodeResponseBody\nodes;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignByCodeResponseBody\props;
use AlibabaCloud\Tea\Model;

class GetProcessDesignByCodeResponseBody extends Model
{
    /**
     * @var approvalSummary[]
     */
    public $approvalSummary;

    /**
     * @var flowConfig
     */
    public $flowConfig;

    /**
     * @var formulaRules[]
     */
    public $formulaRules;

    /**
     * @var nodes[]
     */
    public $nodes;

    /**
     * @var props
     */
    public $props;
    protected $_name = [
        'approvalSummary' => 'approvalSummary',
        'flowConfig' => 'flowConfig',
        'formulaRules' => 'formulaRules',
        'nodes' => 'nodes',
        'props' => 'props',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->approvalSummary) {
            $res['approvalSummary'] = [];
            if (null !== $this->approvalSummary && \is_array($this->approvalSummary)) {
                $n = 0;
                foreach ($this->approvalSummary as $item) {
                    $res['approvalSummary'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->flowConfig) {
            $res['flowConfig'] = null !== $this->flowConfig ? $this->flowConfig->toMap() : null;
        }
        if (null !== $this->formulaRules) {
            $res['formulaRules'] = [];
            if (null !== $this->formulaRules && \is_array($this->formulaRules)) {
                $n = 0;
                foreach ($this->formulaRules as $item) {
                    $res['formulaRules'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->nodes) {
            $res['nodes'] = [];
            if (null !== $this->nodes && \is_array($this->nodes)) {
                $n = 0;
                foreach ($this->nodes as $item) {
                    $res['nodes'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->props) {
            $res['props'] = null !== $this->props ? $this->props->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetProcessDesignByCodeResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['approvalSummary'])) {
            if (!empty($map['approvalSummary'])) {
                $model->approvalSummary = [];
                $n = 0;
                foreach ($map['approvalSummary'] as $item) {
                    $model->approvalSummary[$n++] = null !== $item ? approvalSummary::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['flowConfig'])) {
            $model->flowConfig = flowConfig::fromMap($map['flowConfig']);
        }
        if (isset($map['formulaRules'])) {
            if (!empty($map['formulaRules'])) {
                $model->formulaRules = [];
                $n = 0;
                foreach ($map['formulaRules'] as $item) {
                    $model->formulaRules[$n++] = null !== $item ? formulaRules::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['nodes'])) {
            if (!empty($map['nodes'])) {
                $model->nodes = [];
                $n = 0;
                foreach ($map['nodes'] as $item) {
                    $model->nodes[$n++] = null !== $item ? nodes::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['props'])) {
            $model->props = props::fromMap($map['props']);
        }

        return $model;
    }
}
