<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryCrmGroupChatsResponseBody;

use AlibabaCloud\Tea\Model;

class resultList extends Model
{
    /**
     * @description 客户群chatId
     *
     * @var string
     */
    public $chatId;

    /**
     * @description 客户群openConversationId
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 群组openGroupSetId
     *
     * @var string
     */
    public $openGroupSetId;

    /**
     * @description 群主userId
     *
     * @var string
     */
    public $ownerUserId;

    /**
     * @description 群主userName
     *
     * @var string
     */
    public $ownerUserName;

    /**
     * @description 客户群名
     *
     * @var string
     */
    public $name;

    /**
     * @description 客户群成员数
     *
     * @var int
     */
    public $memberCount;

    /**
     * @description 创建时间(时间戳)
     *
     * @var int
     */
    public $gmtCreate;
    protected $_name = [
        'chatId'             => 'chatId',
        'openConversationId' => 'openConversationId',
        'openGroupSetId'     => 'openGroupSetId',
        'ownerUserId'        => 'ownerUserId',
        'ownerUserName'      => 'ownerUserName',
        'name'               => 'name',
        'memberCount'        => 'memberCount',
        'gmtCreate'          => 'gmtCreate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->chatId) {
            $res['chatId'] = $this->chatId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->openGroupSetId) {
            $res['openGroupSetId'] = $this->openGroupSetId;
        }
        if (null !== $this->ownerUserId) {
            $res['ownerUserId'] = $this->ownerUserId;
        }
        if (null !== $this->ownerUserName) {
            $res['ownerUserName'] = $this->ownerUserName;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->memberCount) {
            $res['memberCount'] = $this->memberCount;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return resultList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['chatId'])) {
            $model->chatId = $map['chatId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['openGroupSetId'])) {
            $model->openGroupSetId = $map['openGroupSetId'];
        }
        if (isset($map['ownerUserId'])) {
            $model->ownerUserId = $map['ownerUserId'];
        }
        if (isset($map['ownerUserName'])) {
            $model->ownerUserName = $map['ownerUserName'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['memberCount'])) {
            $model->memberCount = $map['memberCount'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }

        return $model;
    }
}
