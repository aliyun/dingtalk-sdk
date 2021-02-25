<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models;

use AlibabaCloud\Tea\Model;

class UserTaskReportRequest extends Model
{
    /**
     * @var string
     */
    public $dingCorpId;

    /**
     * @description taskTag
     *
     * @var string
     */
    public $taskTag;

    /**
     * @description operateDate
     *
     * @var string
     */
    public $operateDate;

    /**
     * @description staffId
     *
     * @var string
     */
    public $userid;

    /**
     * @description 业务的幂等ID
     *
     * @var string
     */
    public $bizNo;
    protected $_name = [
        'dingCorpId'  => 'dingCorpId',
        'taskTag'     => 'taskTag',
        'operateDate' => 'operateDate',
        'userid'      => 'userid',
        'bizNo'       => 'bizNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->taskTag) {
            $res['taskTag'] = $this->taskTag;
        }
        if (null !== $this->operateDate) {
            $res['operateDate'] = $this->operateDate;
        }
        if (null !== $this->userid) {
            $res['userid'] = $this->userid;
        }
        if (null !== $this->bizNo) {
            $res['bizNo'] = $this->bizNo;
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
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['taskTag'])) {
            $model->taskTag = $map['taskTag'];
        }
        if (isset($map['operateDate'])) {
            $model->operateDate = $map['operateDate'];
        }
        if (isset($map['userid'])) {
            $model->userid = $map['userid'];
        }
        if (isset($map['bizNo'])) {
            $model->bizNo = $map['bizNo'];
        }

        return $model;
    }
}
