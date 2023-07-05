<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class CancelScheduleConferenceRequest extends Model
{
    /**
     * @example qzR1iSMDvzR9iP7Pxxxxxxxxxxxx
     *
     * @var string
     */
    public $creatorUnionId;

    /**
     * @example 2a489xxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx
     *
     * @var string
     */
    public $scheduleConferenceId;
    protected $_name = [
        'creatorUnionId'       => 'creatorUnionId',
        'scheduleConferenceId' => 'scheduleConferenceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->creatorUnionId) {
            $res['creatorUnionId'] = $this->creatorUnionId;
        }
        if (null !== $this->scheduleConferenceId) {
            $res['scheduleConferenceId'] = $this->scheduleConferenceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CancelScheduleConferenceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creatorUnionId'])) {
            $model->creatorUnionId = $map['creatorUnionId'];
        }
        if (isset($map['scheduleConferenceId'])) {
            $model->scheduleConferenceId = $map['scheduleConferenceId'];
        }

        return $model;
    }
}
