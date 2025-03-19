<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenUserDTO extends Model
{
    /**
     * @example 0342464558835299
     *
     * @var string
     */
    public $dingUserId;

    /**
     * @example 小明
     *
     * @var string
     */
    public $name;

    /**
     * @example 64cd2e9bb80efb17244c650d
     *
     * @var string
     */
    public $userUid;

    /**
     * @example 2639402752-1812711657
     *
     * @var string
     */
    public $workNo;
    protected $_name = [
        'dingUserId' => 'dingUserId',
        'name' => 'name',
        'userUid' => 'userUid',
        'workNo' => 'workNo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingUserId) {
            $res['dingUserId'] = $this->dingUserId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->userUid) {
            $res['userUid'] = $this->userUid;
        }
        if (null !== $this->workNo) {
            $res['workNo'] = $this->workNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenUserDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingUserId'])) {
            $model->dingUserId = $map['dingUserId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['userUid'])) {
            $model->userUid = $map['userUid'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
