<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UserProfileResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $mobile;

    /**
     * @var string
     */
    public $nick;

    /**
     * @var string
     */
    public $orgIds;

    /**
     * @var string
     */
    public $stateCode;
    protected $_name = [
        'mobile' => 'mobile',
        'nick' => 'nick',
        'orgIds' => 'orgIds',
        'stateCode' => 'stateCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->nick) {
            $res['nick'] = $this->nick;
        }
        if (null !== $this->orgIds) {
            $res['orgIds'] = $this->orgIds;
        }
        if (null !== $this->stateCode) {
            $res['stateCode'] = $this->stateCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }
        if (isset($map['orgIds'])) {
            $model->orgIds = $map['orgIds'];
        }
        if (isset($map['stateCode'])) {
            $model->stateCode = $map['stateCode'];
        }

        return $model;
    }
}
