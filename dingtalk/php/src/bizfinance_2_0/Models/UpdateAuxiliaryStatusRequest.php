<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateAuxiliaryStatusRequest extends Model
{
    /**
     * @var string
     */
    public $auxiliaryId;

    /**
     * @var string
     */
    public $auxiliaryType;

    /**
     * @var string
     */
    public $operateType;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'auxiliaryId' => 'auxiliaryId',
        'auxiliaryType' => 'auxiliaryType',
        'operateType' => 'operateType',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->auxiliaryId) {
            $res['auxiliaryId'] = $this->auxiliaryId;
        }
        if (null !== $this->auxiliaryType) {
            $res['auxiliaryType'] = $this->auxiliaryType;
        }
        if (null !== $this->operateType) {
            $res['operateType'] = $this->operateType;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateAuxiliaryStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['auxiliaryId'])) {
            $model->auxiliaryId = $map['auxiliaryId'];
        }
        if (isset($map['auxiliaryType'])) {
            $model->auxiliaryType = $map['auxiliaryType'];
        }
        if (isset($map['operateType'])) {
            $model->operateType = $map['operateType'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
