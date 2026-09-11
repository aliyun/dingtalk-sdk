<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateChecklistRuleShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $contractType;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $itemsShrink;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $riskLevel;

    /**
     * @var string
     */
    public $standpoint;
    protected $_name = [
        'contractType' => 'contract_type',
        'corpId' => 'corp_id',
        'description' => 'description',
        'itemsShrink' => 'items',
        'name' => 'name',
        'riskLevel' => 'risk_level',
        'standpoint' => 'standpoint',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contractType) {
            $res['contract_type'] = $this->contractType;
        }
        if (null !== $this->corpId) {
            $res['corp_id'] = $this->corpId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->itemsShrink) {
            $res['items'] = $this->itemsShrink;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->riskLevel) {
            $res['risk_level'] = $this->riskLevel;
        }
        if (null !== $this->standpoint) {
            $res['standpoint'] = $this->standpoint;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateChecklistRuleShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contract_type'])) {
            $model->contractType = $map['contract_type'];
        }
        if (isset($map['corp_id'])) {
            $model->corpId = $map['corp_id'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['items'])) {
            $model->itemsShrink = $map['items'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['risk_level'])) {
            $model->riskLevel = $map['risk_level'];
        }
        if (isset($map['standpoint'])) {
            $model->standpoint = $map['standpoint'];
        }

        return $model;
    }
}
