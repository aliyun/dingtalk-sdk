<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchOrgCreateHWRequest\openSelectItemList;
use AlibabaCloud\Tea\Model;

class BatchOrgCreateHWRequest extends Model
{
    /**
     * @var string
     */
    public $attributes;

    /**
     * @var string
     */
    public $bizCode;

    /**
     * @var string
     */
    public $courseName;

    /**
     * @var string
     */
    public $hwContent;

    /**
     * @var int
     */
    public $hwDeadline;

    /**
     * @example Y
     *
     * @var string
     */
    public $hwDeadlineOpen;

    /**
     * @var string
     */
    public $hwMedia;

    /**
     * @var string
     */
    public $hwPhoto;

    /**
     * @var string
     */
    public $hwTitle;

    /**
     * @var string
     */
    public $hwType;

    /**
     * @var string
     */
    public $hwVideo;

    /**
     * @var string
     */
    public $identifier;

    /**
     * @var openSelectItemList[]
     */
    public $openSelectItemList;

    /**
     * @var string
     */
    public $scheduledRelease;

    /**
     * @var string
     */
    public $scheduledTime;

    /**
     * @var string
     */
    public $status;

    /**
     * @var string
     */
    public $targetRole;

    /**
     * @var string
     */
    public $teacherName;

    /**
     * @var string
     */
    public $teacherUserId;
    protected $_name = [
        'attributes'         => 'attributes',
        'bizCode'            => 'bizCode',
        'courseName'         => 'courseName',
        'hwContent'          => 'hwContent',
        'hwDeadline'         => 'hwDeadline',
        'hwDeadlineOpen'     => 'hwDeadlineOpen',
        'hwMedia'            => 'hwMedia',
        'hwPhoto'            => 'hwPhoto',
        'hwTitle'            => 'hwTitle',
        'hwType'             => 'hwType',
        'hwVideo'            => 'hwVideo',
        'identifier'         => 'identifier',
        'openSelectItemList' => 'openSelectItemList',
        'scheduledRelease'   => 'scheduledRelease',
        'scheduledTime'      => 'scheduledTime',
        'status'             => 'status',
        'targetRole'         => 'targetRole',
        'teacherName'        => 'teacherName',
        'teacherUserId'      => 'teacherUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attributes) {
            $res['attributes'] = $this->attributes;
        }
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->courseName) {
            $res['courseName'] = $this->courseName;
        }
        if (null !== $this->hwContent) {
            $res['hwContent'] = $this->hwContent;
        }
        if (null !== $this->hwDeadline) {
            $res['hwDeadline'] = $this->hwDeadline;
        }
        if (null !== $this->hwDeadlineOpen) {
            $res['hwDeadlineOpen'] = $this->hwDeadlineOpen;
        }
        if (null !== $this->hwMedia) {
            $res['hwMedia'] = $this->hwMedia;
        }
        if (null !== $this->hwPhoto) {
            $res['hwPhoto'] = $this->hwPhoto;
        }
        if (null !== $this->hwTitle) {
            $res['hwTitle'] = $this->hwTitle;
        }
        if (null !== $this->hwType) {
            $res['hwType'] = $this->hwType;
        }
        if (null !== $this->hwVideo) {
            $res['hwVideo'] = $this->hwVideo;
        }
        if (null !== $this->identifier) {
            $res['identifier'] = $this->identifier;
        }
        if (null !== $this->openSelectItemList) {
            $res['openSelectItemList'] = [];
            if (null !== $this->openSelectItemList && \is_array($this->openSelectItemList)) {
                $n = 0;
                foreach ($this->openSelectItemList as $item) {
                    $res['openSelectItemList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->scheduledRelease) {
            $res['scheduledRelease'] = $this->scheduledRelease;
        }
        if (null !== $this->scheduledTime) {
            $res['scheduledTime'] = $this->scheduledTime;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->targetRole) {
            $res['targetRole'] = $this->targetRole;
        }
        if (null !== $this->teacherName) {
            $res['teacherName'] = $this->teacherName;
        }
        if (null !== $this->teacherUserId) {
            $res['teacherUserId'] = $this->teacherUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchOrgCreateHWRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attributes'])) {
            $model->attributes = $map['attributes'];
        }
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['courseName'])) {
            $model->courseName = $map['courseName'];
        }
        if (isset($map['hwContent'])) {
            $model->hwContent = $map['hwContent'];
        }
        if (isset($map['hwDeadline'])) {
            $model->hwDeadline = $map['hwDeadline'];
        }
        if (isset($map['hwDeadlineOpen'])) {
            $model->hwDeadlineOpen = $map['hwDeadlineOpen'];
        }
        if (isset($map['hwMedia'])) {
            $model->hwMedia = $map['hwMedia'];
        }
        if (isset($map['hwPhoto'])) {
            $model->hwPhoto = $map['hwPhoto'];
        }
        if (isset($map['hwTitle'])) {
            $model->hwTitle = $map['hwTitle'];
        }
        if (isset($map['hwType'])) {
            $model->hwType = $map['hwType'];
        }
        if (isset($map['hwVideo'])) {
            $model->hwVideo = $map['hwVideo'];
        }
        if (isset($map['identifier'])) {
            $model->identifier = $map['identifier'];
        }
        if (isset($map['openSelectItemList'])) {
            if (!empty($map['openSelectItemList'])) {
                $model->openSelectItemList = [];
                $n                         = 0;
                foreach ($map['openSelectItemList'] as $item) {
                    $model->openSelectItemList[$n++] = null !== $item ? openSelectItemList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['scheduledRelease'])) {
            $model->scheduledRelease = $map['scheduledRelease'];
        }
        if (isset($map['scheduledTime'])) {
            $model->scheduledTime = $map['scheduledTime'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['targetRole'])) {
            $model->targetRole = $map['targetRole'];
        }
        if (isset($map['teacherName'])) {
            $model->teacherName = $map['teacherName'];
        }
        if (isset($map['teacherUserId'])) {
            $model->teacherUserId = $map['teacherUserId'];
        }

        return $model;
    }
}
