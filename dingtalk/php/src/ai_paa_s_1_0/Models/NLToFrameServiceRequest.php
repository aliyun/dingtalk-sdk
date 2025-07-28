<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models;

use AlibabaCloud\Tea\Model;

class NLToFrameServiceRequest extends Model
{
    /**
     * @var string
     */
    public $extensionStr;

    /**
     * @var bool
     */
    public $isNewModel;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $modelId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $modelName;

    /**
     * @var int
     */
    public $userId;
    protected $_name = [
        'extensionStr' => 'extensionStr',
        'isNewModel' => 'isNewModel',
        'modelId' => 'modelId',
        'modelName' => 'modelName',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->extensionStr) {
            $res['extensionStr'] = $this->extensionStr;
        }
        if (null !== $this->isNewModel) {
            $res['isNewModel'] = $this->isNewModel;
        }
        if (null !== $this->modelId) {
            $res['modelId'] = $this->modelId;
        }
        if (null !== $this->modelName) {
            $res['modelName'] = $this->modelName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return NLToFrameServiceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['extensionStr'])) {
            $model->extensionStr = $map['extensionStr'];
        }
        if (isset($map['isNewModel'])) {
            $model->isNewModel = $map['isNewModel'];
        }
        if (isset($map['modelId'])) {
            $model->modelId = $map['modelId'];
        }
        if (isset($map['modelName'])) {
            $model->modelName = $map['modelName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
