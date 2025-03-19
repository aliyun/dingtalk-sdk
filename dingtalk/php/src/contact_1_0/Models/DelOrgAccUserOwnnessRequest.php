<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class DelOrgAccUserOwnnessRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 2
     *
     * @var int
     */
    public $ownenssType;

    /**
     * @description This parameter is required.
     *
     * @example 123456
     *
     * @var int
     */
    public $ownnessId;

    /**
     * @description This parameter is required.
     *
     * @example 123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'ownenssType' => 'ownenssType',
        'ownnessId' => 'ownnessId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->ownenssType) {
            $res['ownenssType'] = $this->ownenssType;
        }
        if (null !== $this->ownnessId) {
            $res['ownnessId'] = $this->ownnessId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DelOrgAccUserOwnnessRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ownenssType'])) {
            $model->ownenssType = $map['ownenssType'];
        }
        if (isset($map['ownnessId'])) {
            $model->ownnessId = $map['ownnessId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
