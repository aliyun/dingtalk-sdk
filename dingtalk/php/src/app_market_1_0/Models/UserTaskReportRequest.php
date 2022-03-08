<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models;

use AlibabaCloud\Tea\Model;

class UserTaskReportRequest extends Model
{
    /**
     * @description 业务的幂等ID
     *
     * @var string
     */
    public $bizNo;

    /**
     * @description operateDate
     *
     * @var string
     */
    public $operateDate;

    /**
     * @description taskTag
     *
     * @var string
     */
    public $taskTag;

    /**
     * @description staffId
     *
     * @var string
     */
    public $userid;
    protected $_name = [
        'bizNo'       => 'bizNo',
        'operateDate' => 'operateDate',
        'taskTag'     => 'taskTag',
        'userid'      => 'userid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizNo) {
            $res['bizNo'] = $this->bizNo;
        }
        if (null !== $this->operateDate) {
            $res['operateDate'] = $this->operateDate;
        }
        if (null !== $this->taskTag) {
            $res['taskTag'] = $this->taskTag;
        }
        if (null !== $this->userid) {
            $res['userid'] = $this->userid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UserTaskReportRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizNo'])) {
            $model->bizNo = $map['bizNo'];
        }
        if (isset($map['operateDate'])) {
            $model->operateDate = $map['operateDate'];
        }
        if (isset($map['taskTag'])) {
            $model->taskTag = $map['taskTag'];
        }
        if (isset($map['userid'])) {
            $model->userid = $map['userid'];
        }

        return $model;
    }
}
