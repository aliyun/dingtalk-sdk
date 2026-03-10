<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models;

use AlibabaCloud\Tea\Model;

class WeiqiaoAluminumSubmitRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example {         "sample_1": {             \"Weight\": 102000,             \"Al\": 97, \"Si\": 0.05, \"Fe\": 0.05         },         "sample_2": {             \"Weight\": 102000,             \"Al\": 98, \"Si\": 0.04, \"Fe\": 0.05         }     }
     *
     * @var mixed
     */
    public $currentFurnace;

    /**
     * @description This parameter is required.
     *
     * @example {}
     *
     * @var mixed
     */
    public $dilutionConfig;

    /**
     * @var mixed
     */
    public $historyFurnace;

    /**
     * @description This parameter is required.
     *
     * @example [         {             \"Name\": \"Al-Si-Material\",             \"Primary_element\": \"Si\",             \"Si\": 10.0, \"Al\": 90.0         },         {             \"Name\": \"Al-Fe-Material\",             \"Primary_element\": \"Fe\",             \"Fe\": 10.0, \"Al\": 90.0         }     ]
     *
     * @var mixed
     */
    public $rawMaterials;

    /**
     * @description This parameter is required.
     *
     * @example test_batch_001
     *
     * @var mixed
     */
    public $target;

    /**
     * @description This parameter is required.
     *
     * @example {         \"Si\": [0.1, 0.2, 0.3],         \"Fe\": [0.1, 0.2, 0.3]     }
     *
     * @var mixed
     */
    public $targetRanges;
    protected $_name = [
        'currentFurnace' => 'current_furnace',
        'dilutionConfig' => 'dilution_config',
        'historyFurnace' => 'history_furnace',
        'rawMaterials' => 'raw_materials',
        'target' => 'target',
        'targetRanges' => 'target_ranges',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->currentFurnace) {
            $res['current_furnace'] = $this->currentFurnace;
        }
        if (null !== $this->dilutionConfig) {
            $res['dilution_config'] = $this->dilutionConfig;
        }
        if (null !== $this->historyFurnace) {
            $res['history_furnace'] = $this->historyFurnace;
        }
        if (null !== $this->rawMaterials) {
            $res['raw_materials'] = $this->rawMaterials;
        }
        if (null !== $this->target) {
            $res['target'] = $this->target;
        }
        if (null !== $this->targetRanges) {
            $res['target_ranges'] = $this->targetRanges;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return WeiqiaoAluminumSubmitRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['current_furnace'])) {
            $model->currentFurnace = $map['current_furnace'];
        }
        if (isset($map['dilution_config'])) {
            $model->dilutionConfig = $map['dilution_config'];
        }
        if (isset($map['history_furnace'])) {
            $model->historyFurnace = $map['history_furnace'];
        }
        if (isset($map['raw_materials'])) {
            $model->rawMaterials = $map['raw_materials'];
        }
        if (isset($map['target'])) {
            $model->target = $map['target'];
        }
        if (isset($map['target_ranges'])) {
            $model->targetRanges = $map['target_ranges'];
        }

        return $model;
    }
}
