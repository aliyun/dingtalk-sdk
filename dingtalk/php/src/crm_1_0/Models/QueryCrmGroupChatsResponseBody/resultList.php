<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryCrmGroupChatsResponseBody;

use AlibabaCloud\Tea\Model;

class resultList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1640239655539
     *
     * @var int
     */
    public $gmtCreate;

    /**
     * @description This parameter is required.
     *
     * @example 100
     *
     * @var int
     */
    public $memberCount;

    /**
     * @description This parameter is required.
     *
     * @example 营销1群
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example afsad21
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example afsdba23
     *
     * @var string
     */
    public $openGroupSetId;

    /**
     * @description This parameter is required.
     *
     * @example afds12
     *
     * @var string
     */
    public $ownerUserId;

    /**
     * @description This parameter is required.
     *
     * @example XX
     *
     * @var string
     */
    public $ownerUserName;
    protected $_name = [
        'gmtCreate'          => 'gmtCreate',
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
     * @return resultList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
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
