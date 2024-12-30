<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\UpdateStandardTemplateRequest;

use AlibabaCloud\Tea\Model;

class actions extends Model
{
    /**
     * @var string
     */
    public $actionGroup;

    /**
     * @var string
     */
    public $name;

    /**
     * @var bool
     */
    public $needReason;

    /**
     * @var bool
     */
    public $needReasonRequired;

    /**
     * @var int
     */
    public $order;

    /**
     * @var int
     */
    public $styleType;
    protected $_name = [
        'actionGroup'        => 'actionGroup',
        'name'               => 'name',
        'needReason'         => 'needReason',
        'needReasonRequired' => 'needReasonRequired',
        'order'              => 'order',
        'styleType'          => 'styleType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionGroup) {
            $res['actionGroup'] = $this->actionGroup;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->needReason) {
            $res['needReason'] = $this->needReason;
        }
        if (null !== $this->needReasonRequired) {
            $res['needReasonRequired'] = $this->needReasonRequired;
        }
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }
        if (null !== $this->styleType) {
            $res['styleType'] = $this->styleType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return actions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionGroup'])) {
            $model->actionGroup = $map['actionGroup'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['needReason'])) {
            $model->needReason = $map['needReason'];
        }
        if (isset($map['needReasonRequired'])) {
            $model->needReasonRequired = $map['needReasonRequired'];
        }
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }
        if (isset($map['styleType'])) {
            $model->styleType = $map['styleType'];
        }

        return $model;
    }
}
