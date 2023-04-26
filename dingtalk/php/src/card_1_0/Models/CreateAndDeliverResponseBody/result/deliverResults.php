<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverResponseBody\result;

use AlibabaCloud\Tea\Model;

class deliverResults extends Model
{
    /**
     * @var string
     */
    public $errorMsg;

    /**
     * @example cid1234abcd
     *
     * @var string
     */
    public $spaceId;

    /**
     * @example IM_GROUP
     *
     * @var string
     */
    public $spaceType;

    /**
     * @var bool
     */
    public $success;
    protected $_name = [
        'errorMsg'  => 'errorMsg',
        'spaceId'   => 'spaceId',
        'spaceType' => 'spaceType',
        'success'   => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->errorMsg) {
            $res['errorMsg'] = $this->errorMsg;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->spaceType) {
            $res['spaceType'] = $this->spaceType;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return deliverResults
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['errorMsg'])) {
            $model->errorMsg = $map['errorMsg'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['spaceType'])) {
            $model->spaceType = $map['spaceType'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
