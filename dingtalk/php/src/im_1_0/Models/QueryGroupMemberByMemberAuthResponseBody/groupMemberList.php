<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberByMemberAuthResponseBody;

use AlibabaCloud\Tea\Model;

class groupMemberList extends Model
{
    /**
     * @description 群内昵称
     *
     *
     * @var string
     */
    public $groupNickName;

    /**
     * @description 企业内成员姓名
     *
     * @var string
     */
    public $orgName;

    /**
     * @description 头像url
     *
     * @var string
     */
    public $profilePhotoUrl;

    /**
     * @description 员工id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'groupNickName'   => 'groupNickName',
        'orgName'         => 'orgName',
        'profilePhotoUrl' => 'profilePhotoUrl',
        'userId'          => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupNickName) {
            $res['groupNickName'] = $this->groupNickName;
        }
        if (null !== $this->orgName) {
            $res['orgName'] = $this->orgName;
        }
        if (null !== $this->profilePhotoUrl) {
            $res['profilePhotoUrl'] = $this->profilePhotoUrl;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groupMemberList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupNickName'])) {
            $model->groupNickName = $map['groupNickName'];
        }
        if (isset($map['orgName'])) {
            $model->orgName = $map['orgName'];
        }
        if (isset($map['profilePhotoUrl'])) {
            $model->profilePhotoUrl = $map['profilePhotoUrl'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
