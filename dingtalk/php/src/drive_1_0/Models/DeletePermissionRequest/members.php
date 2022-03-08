<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeletePermissionRequest;

use AlibabaCloud\Tea\Model;

class members extends Model
{
    /**
     * @description 企业corpId
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 成员id
     *
     * @var string
     */
    public $memberId;

    /**
     * @description 成员类型
     *
     * @var string
     */
    public $memberType;
    protected $_name = [
        'corpId'     => 'corpId',
        'memberId'   => 'memberId',
        'memberType' => 'memberType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->memberId) {
            $res['memberId'] = $this->memberId;
        }
        if (null !== $this->memberType) {
            $res['memberType'] = $this->memberType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return members
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['memberId'])) {
            $model->memberId = $map['memberId'];
        }
        if (isset($map['memberType'])) {
            $model->memberType = $map['memberType'];
        }

        return $model;
    }
}
