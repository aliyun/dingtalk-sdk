<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupInfoByAppCidsResponseBody;

use AlibabaCloud\Tea\Model;

class groupInfoList extends Model
{
    /**
     * @example $2$123456$2
     *
     * @var string
     */
    public $appCid;

    /**
     * @example ding1234
     *
     * @var string
     */
    public $corpId;

    /**
     * @example @abc
     *
     * @var string
     */
    public $groupAvatar;

    /**
     * @example https://abc
     *
     * @var string
     */
    public $groupAvatarUrl;

    /**
     * @example 群名称
     *
     * @var string
     */
    public $groupName;

    /**
     * @example 123456a==
     *
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'appCid' => 'appCid',
        'corpId' => 'corpId',
        'groupAvatar' => 'groupAvatar',
        'groupAvatarUrl' => 'groupAvatarUrl',
        'groupName' => 'groupName',
        'openConversationId' => 'openConversationId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appCid) {
            $res['appCid'] = $this->appCid;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->groupAvatar) {
            $res['groupAvatar'] = $this->groupAvatar;
        }
        if (null !== $this->groupAvatarUrl) {
            $res['groupAvatarUrl'] = $this->groupAvatarUrl;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groupInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appCid'])) {
            $model->appCid = $map['appCid'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['groupAvatar'])) {
            $model->groupAvatar = $map['groupAvatar'];
        }
        if (isset($map['groupAvatarUrl'])) {
            $model->groupAvatarUrl = $map['groupAvatarUrl'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
