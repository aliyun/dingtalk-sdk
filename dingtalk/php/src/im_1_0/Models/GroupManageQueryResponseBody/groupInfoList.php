<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GroupManageQueryResponseBody;

use AlibabaCloud\Tea\Model;

class groupInfoList extends Model
{
    /**
     * @description 禁言模式
     *
     * @var int
     */
    public $banWordsMode;

    /**
     * @description 群容量
     *
     * @var int
     */
    public $capacity;

    /**
     * @description 群创建时间
     *
     * @var int
     */
    public $createdAt;

    /**
     * @description 扩展信息
     *
     * @var mixed[]
     */
    public $extInfo;

    /**
     * @var string[]
     */
    public $groupAdminList;

    /**
     * @description 群主userid
     *
     * @var string
     */
    public $groupOwner;

    /**
     * @description 群标题
     *
     * @var string
     */
    public $groupTitle;

    /**
     * @description 当前群人数
     *
     * @var int
     */
    public $memberCount;

    /**
     * @description 开放的群id
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 群类型
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'banWordsMode'       => 'banWordsMode',
        'capacity'           => 'capacity',
        'createdAt'          => 'createdAt',
        'extInfo'            => 'extInfo',
        'groupAdminList'     => 'groupAdminList',
        'groupOwner'         => 'groupOwner',
        'groupTitle'         => 'groupTitle',
        'memberCount'        => 'memberCount',
        'openConversationId' => 'openConversationId',
        'type'               => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->banWordsMode) {
            $res['banWordsMode'] = $this->banWordsMode;
        }
        if (null !== $this->capacity) {
            $res['capacity'] = $this->capacity;
        }
        if (null !== $this->createdAt) {
            $res['createdAt'] = $this->createdAt;
        }
        if (null !== $this->extInfo) {
            $res['extInfo'] = $this->extInfo;
        }
        if (null !== $this->groupAdminList) {
            $res['groupAdminList'] = $this->groupAdminList;
        }
        if (null !== $this->groupOwner) {
            $res['groupOwner'] = $this->groupOwner;
        }
        if (null !== $this->groupTitle) {
            $res['groupTitle'] = $this->groupTitle;
        }
        if (null !== $this->memberCount) {
            $res['memberCount'] = $this->memberCount;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
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
        if (isset($map['banWordsMode'])) {
            $model->banWordsMode = $map['banWordsMode'];
        }
        if (isset($map['capacity'])) {
            $model->capacity = $map['capacity'];
        }
        if (isset($map['createdAt'])) {
            $model->createdAt = $map['createdAt'];
        }
        if (isset($map['extInfo'])) {
            $model->extInfo = $map['extInfo'];
        }
        if (isset($map['groupAdminList'])) {
            if (!empty($map['groupAdminList'])) {
                $model->groupAdminList = $map['groupAdminList'];
            }
        }
        if (isset($map['groupOwner'])) {
            $model->groupOwner = $map['groupOwner'];
        }
        if (isset($map['groupTitle'])) {
            $model->groupTitle = $map['groupTitle'];
        }
        if (isset($map['memberCount'])) {
            $model->memberCount = $map['memberCount'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
