<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class IntelligentSendCardRequest extends Model
{
    /**
     * @var bool
     */
    public $atAll;

    /**
     * @var string[]
     */
    public $atOpenGroupRoleIds;

    /**
     * @var string[]
     */
    public $atUnionIds;

    /**
     * @var string[]
     */
    public $atUserIds;

    /**
     * @var string[]
     */
    public $excludeIds;

    /**
     * @example cidt*****Xa4K10w==
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @var string
     */
    public $outTrackId;

    /**
     * @var string[]
     */
    public $receivers;

    /**
     * @example axcf*-*****-*****-23da*
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'atAll' => 'atAll',
        'atOpenGroupRoleIds' => 'atOpenGroupRoleIds',
        'atUnionIds' => 'atUnionIds',
        'atUserIds' => 'atUserIds',
        'excludeIds' => 'excludeIds',
        'openConversationId' => 'openConversationId',
        'outTrackId' => 'outTrackId',
        'receivers' => 'receivers',
        'uuid' => 'uuid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->atAll) {
            $res['atAll'] = $this->atAll;
        }
        if (null !== $this->atOpenGroupRoleIds) {
            $res['atOpenGroupRoleIds'] = $this->atOpenGroupRoleIds;
        }
        if (null !== $this->atUnionIds) {
            $res['atUnionIds'] = $this->atUnionIds;
        }
        if (null !== $this->atUserIds) {
            $res['atUserIds'] = $this->atUserIds;
        }
        if (null !== $this->excludeIds) {
            $res['excludeIds'] = $this->excludeIds;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
        }
        if (null !== $this->receivers) {
            $res['receivers'] = $this->receivers;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IntelligentSendCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['atAll'])) {
            $model->atAll = $map['atAll'];
        }
        if (isset($map['atOpenGroupRoleIds'])) {
            if (!empty($map['atOpenGroupRoleIds'])) {
                $model->atOpenGroupRoleIds = $map['atOpenGroupRoleIds'];
            }
        }
        if (isset($map['atUnionIds'])) {
            if (!empty($map['atUnionIds'])) {
                $model->atUnionIds = $map['atUnionIds'];
            }
        }
        if (isset($map['atUserIds'])) {
            if (!empty($map['atUserIds'])) {
                $model->atUserIds = $map['atUserIds'];
            }
        }
        if (isset($map['excludeIds'])) {
            if (!empty($map['excludeIds'])) {
                $model->excludeIds = $map['excludeIds'];
            }
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }
        if (isset($map['receivers'])) {
            if (!empty($map['receivers'])) {
                $model->receivers = $map['receivers'];
            }
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
