<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmGroupChatMultiResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 1642078998377
     *
     * @var int
     */
    public $gmtCreate;

    /**
     * @example https://static/xx.com/xx.jpg
     *
     * @var string
     */
    public $iconUrl;

    /**
     * @example 12
     *
     * @var int
     */
    public $memberCount;

    /**
     * @example 营销1群
     *
     * @var string
     */
    public $name;

    /**
     * @example xx==
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example xxa==
     *
     * @var string
     */
    public $openGroupSetId;

    /**
     * @example axaf12
     *
     * @var string
     */
    public $ownerUserId;

    /**
     * @example XX
     *
     * @var string
     */
    public $ownerUserName;
    protected $_name = [
        'gmtCreate' => 'gmtCreate',
        'iconUrl' => 'iconUrl',
        'memberCount' => 'memberCount',
        'name' => 'name',
        'openConversationId' => 'openConversationId',
        'openGroupSetId' => 'openGroupSetId',
        'ownerUserId' => 'ownerUserId',
        'ownerUserName' => 'ownerUserName',
    ];

    public function validate() {}

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
