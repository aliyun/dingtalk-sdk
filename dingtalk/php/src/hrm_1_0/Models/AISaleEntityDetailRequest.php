<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class AISaleEntityDetailRequest extends Model
{
    /**
     * @var string
     */
    public $entityId;

    /**
     * @var string
     */
    public $entityType;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'entityId' => 'entityId',
        'entityType' => 'entityType',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->entityId) {
            $res['entityId'] = $this->entityId;
        }
        if (null !== $this->entityType) {
            $res['entityType'] = $this->entityType;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AISaleEntityDetailRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['entityId'])) {
            $model->entityId = $map['entityId'];
        }
        if (isset($map['entityType'])) {
            $model->entityType = $map['entityType'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
