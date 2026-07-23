<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ExclusiveBannerRequest extends Model
{
    /**
     * @var bool
     */
    public $allOrg;

    /**
     * @var int
     */
    public $duration;

    /**
     * @var int
     */
    public $endTime;

    /**
     * @var string
     */
    public $imageMediaId;

    /**
     * @var string
     */
    public $openLink;

    /**
     * @var int
     */
    public $startTime;

    /**
     * @var string[]
     */
    public $userList;
    protected $_name = [
        'allOrg' => 'allOrg',
        'duration' => 'duration',
        'endTime' => 'endTime',
        'imageMediaId' => 'imageMediaId',
        'openLink' => 'openLink',
        'startTime' => 'startTime',
        'userList' => 'userList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->allOrg) {
            $res['allOrg'] = $this->allOrg;
        }
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->imageMediaId) {
            $res['imageMediaId'] = $this->imageMediaId;
        }
        if (null !== $this->openLink) {
            $res['openLink'] = $this->openLink;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->userList) {
            $res['userList'] = $this->userList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ExclusiveBannerRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['allOrg'])) {
            $model->allOrg = $map['allOrg'];
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['imageMediaId'])) {
            $model->imageMediaId = $map['imageMediaId'];
        }
        if (isset($map['openLink'])) {
            $model->openLink = $map['openLink'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['userList'])) {
            if (!empty($map['userList'])) {
                $model->userList = $map['userList'];
            }
        }

        return $model;
    }
}
