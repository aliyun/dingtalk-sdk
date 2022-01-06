<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateGroupSetRequest extends Model
{
    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $ownerUserId;

    /**
     * @var string
     */
    public $creatorUserId;

    /**
     * @var string
     */
    public $templateId;

    /**
     * @var int
     */
    public $memberQuota;

    /**
     * @var string
     */
    public $managerUserIds;

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
    public $relationType;
    protected $_name = [
        'name'           => 'name',
        'ownerUserId'    => 'ownerUserId',
        'creatorUserId'  => 'creatorUserId',
        'templateId'     => 'templateId',
        'memberQuota'    => 'memberQuota',
        'managerUserIds' => 'managerUserIds',
        'notice'         => 'notice',
        'noticeToped'    => 'noticeToped',
        'relationType'   => 'relationType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->ownerUserId) {
            $res['ownerUserId'] = $this->ownerUserId;
        }
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->memberQuota) {
            $res['memberQuota'] = $this->memberQuota;
        }
        if (null !== $this->managerUserIds) {
            $res['managerUserIds'] = $this->managerUserIds;
        }
        if (null !== $this->notice) {
            $res['notice'] = $this->notice;
        }
        if (null !== $this->noticeToped) {
            $res['noticeToped'] = $this->noticeToped;
        }
        if (null !== $this->relationType) {
            $res['relationType'] = $this->relationType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateGroupSetRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['ownerUserId'])) {
            $model->ownerUserId = $map['ownerUserId'];
        }
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['memberQuota'])) {
            $model->memberQuota = $map['memberQuota'];
        }
        if (isset($map['managerUserIds'])) {
            $model->managerUserIds = $map['managerUserIds'];
        }
        if (isset($map['notice'])) {
            $model->notice = $map['notice'];
        }
        if (isset($map['noticeToped'])) {
            $model->noticeToped = $map['noticeToped'];
        }
        if (isset($map['relationType'])) {
            $model->relationType = $map['relationType'];
        }

        return $model;
    }
}