<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListPermissionsResponseBody\members;

use AlibabaCloud\Tea\Model;

class member extends Model
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
     * @description 成员名称
     *
     * @var string
     */
    public $memberName;

    /**
     * @description 成员类型
     *
     * @var string
     */
    public $memberType;
    protected $_name = [
        'corpId'     => 'corpId',
        'memberId'   => 'memberId',
        'memberName' => 'memberName',
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
        if (null !== $this->memberName) {
            $res['memberName'] = $this->memberName;
        }
        if (null !== $this->memberType) {
            $res['memberType'] = $this->memberType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return member
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
        if (isset($map['memberName'])) {
            $model->memberName = $map['memberName'];
        }
        if (isset($map['memberType'])) {
            $model->memberType = $map['memberType'];
        }

        return $model;
    }
}
