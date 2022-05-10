<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateGroupSetRequest extends Model
{
    /**
     * @var string
     */
    public $managerUserIds;

    /**
     * @var int
     */
    public $memberQuota;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $notice;

    /**
     * @var int
     */
    public $noticeToped;

    /**
     * @var string
     */
    public $openGroupSetId;

    /**
     * @var string
     */
    public $ownerUserId;

    /**
     * @var string
     */
    public $templateId;

    /**
     * @var string
     */
    public $welcome;
    protected $_name = [
        'managerUserIds' => 'managerUserIds',
        'memberQuota'    => 'memberQuota',
        'name'           => 'name',
        'notice'         => 'notice',
        'noticeToped'    => 'noticeToped',
        'openGroupSetId' => 'openGroupSetId',
        'ownerUserId'    => 'ownerUserId',
        'templateId'     => 'templateId',
        'welcome'        => 'welcome',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->managerUserIds) {
            $res['managerUserIds'] = $this->managerUserIds;
        }
        if (null !== $this->memberQuota) {
            $res['memberQuota'] = $this->memberQuota;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->notice) {
            $res['notice'] = $this->notice;
        }
        if (null !== $this->noticeToped) {
            $res['noticeToped'] = $this->noticeToped;
        }
        if (null !== $this->openGroupSetId) {
            $res['openGroupSetId'] = $this->openGroupSetId;
        }
        if (null !== $this->ownerUserId) {
            $res['ownerUserId'] = $this->ownerUserId;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->welcome) {
            $res['welcome'] = $this->welcome;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateGroupSetRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['managerUserIds'])) {
            $model->managerUserIds = $map['managerUserIds'];
        }
        if (isset($map['memberQuota'])) {
            $model->memberQuota = $map['memberQuota'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['notice'])) {
            $model->notice = $map['notice'];
        }
        if (isset($map['noticeToped'])) {
            $model->noticeToped = $map['noticeToped'];
        }
        if (isset($map['openGroupSetId'])) {
            $model->openGroupSetId = $map['openGroupSetId'];
        }
        if (isset($map['ownerUserId'])) {
            $model->ownerUserId = $map['ownerUserId'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['welcome'])) {
            $model->welcome = $map['welcome'];
        }

        return $model;
    }
}
