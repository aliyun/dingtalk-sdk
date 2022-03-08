<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmGroupChatMultiResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 创建时间(时间戳)。
     *
     * @var int
     */
    public $gmtCreate;

    /**
     * @description 群头像地址。
     *
     * @var string
     */
    public $iconUrl;

    /**
     * @description 客户群成员数。
     *
     * @var int
     */
    public $memberCount;

    /**
     * @description 客户群名
     *
     * @var string
     */
    public $name;

    /**
     * @description 客户群openConversationId。
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 群组openGroupSetId。
     *
     * @var string
     */
    public $openGroupSetId;

    /**
     * @description 群主userId。
     *
     * @var string
     */
    public $ownerUserId;

    /**
     * @description 群主userName。
     *
     * @var string
     */
    public $ownerUserName;
    protected $_name = [
        'gmtCreate'          => 'gmtCreate',
        'iconUrl'            => 'iconUrl',
        'memberCount'        => 'memberCount',
        'name'               => 'name',
        'openConversationId' => 'openConversationId',
        'openGroupSetId'     => 'openGroupSetId',
        'ownerUserId'        => 'ownerUserId',
        'ownerUserName'      => 'ownerUserName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->iconUrl) {
            $res['iconUrl'] = $this->iconUrl;
        }
        if (null !== $this->memberCount) {
            $res['memberCount'] = $this->memberCount;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
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
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['iconUrl'])) {
            $model->iconUrl = $map['iconUrl'];
        }
        if (isset($map['memberCount'])) {
            $model->memberCount = $map['memberCount'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
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

        return $model;
    }
}
