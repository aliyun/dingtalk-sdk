<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetClassTagRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $entityId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $tagCode;
    protected $_name = [
        'entityId' => 'entityId',
        'tagCode' => 'tagCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->entityId) {
            $res['entityId'] = $this->entityId;
        }
        if (null !== $this->tagCode) {
            $res['tagCode'] = $this->tagCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetClassTagRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['entityId'])) {
            $model->entityId = $map['entityId'];
        }
        if (isset($map['tagCode'])) {
            $model->tagCode = $map['tagCode'];
        }

        return $model;
    }
}
