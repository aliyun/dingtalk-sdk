<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\GetTemplateListResponseBody\data;

use AlibabaCloud\Tea\Model;

class actions extends Model
{
    /**
     * @var string
     */
    public $actionKey;

    /**
     * @var string
     */
    public $description;

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
        'actionKey' => 'actionKey',
        'description' => 'description',
        'name' => 'name',
        'needReason' => 'needReason',
        'needReasonRequired' => 'needReasonRequired',
        'order' => 'order',
        'styleType' => 'styleType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionKey) {
            $res['actionKey'] = $this->actionKey;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
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
        if (isset($map['actionKey'])) {
            $model->actionKey = $map['actionKey'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
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
