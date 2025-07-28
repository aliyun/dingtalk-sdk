<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberByMemberAuthResponseBody;

use AlibabaCloud\Tea\Model;

class groupMemberList extends Model
{
    /**
     * @example 张三
     *
     * @var string
     */
    public $groupNickName;

    /**
     * @example 张某某
     *
     * @var string
     */
    public $orgName;

    /**
     * @example https://xxx
     *
     * @var string
     */
    public $profilePhotoUrl;

    /**
     * @example xxx
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'groupNickName' => 'groupNickName',
        'orgName' => 'orgName',
        'profilePhotoUrl' => 'profilePhotoUrl',
        'userId' => 'userId',
    ];

    public function validate() {}

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
