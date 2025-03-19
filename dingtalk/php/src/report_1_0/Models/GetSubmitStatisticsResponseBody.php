<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSubmitStatisticsResponseBody extends Model
{
    /**
     * @example 3
     *
     * @var int
     */
    public $shouldRemindTimes;

    /**
     * @example 日报
     *
     * @var string
     */
    public $templateName;

    /**
     * @var string[]
     */
    public $userDeptMap;

    /**
     * @var int[]
     */
    public $userIdCountMap;

    /**
     * @var mixed[][]
     */
    public $userIdStatusMap;

    /**
     * @var string[]
     */
    public $userIds;

    /**
     * @var UserMapValue[]
     */
    public $userMap;
    protected $_name = [
        'shouldRemindTimes' => 'shouldRemindTimes',
        'templateName' => 'templateName',
        'userDeptMap' => 'userDeptMap',
        'userIdCountMap' => 'userIdCountMap',
        'userIdStatusMap' => 'userIdStatusMap',
        'userIds' => 'userIds',
        'userMap' => 'userMap',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->shouldRemindTimes) {
            $res['shouldRemindTimes'] = $this->shouldRemindTimes;
        }
        if (null !== $this->templateName) {
            $res['templateName'] = $this->templateName;
        }
        if (null !== $this->userDeptMap) {
            $res['userDeptMap'] = $this->userDeptMap;
        }
        if (null !== $this->userIdCountMap) {
            $res['userIdCountMap'] = $this->userIdCountMap;
        }
        if (null !== $this->userIdStatusMap) {
            $res['userIdStatusMap'] = $this->userIdStatusMap;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }
        if (null !== $this->userMap) {
            $res['userMap'] = [];
            if (null !== $this->userMap && \is_array($this->userMap)) {
                foreach ($this->userMap as $key => $val) {
                    $res['userMap'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSubmitStatisticsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['shouldRemindTimes'])) {
            $model->shouldRemindTimes = $map['shouldRemindTimes'];
        }
        if (isset($map['templateName'])) {
            $model->templateName = $map['templateName'];
        }
        if (isset($map['userDeptMap'])) {
            $model->userDeptMap = $map['userDeptMap'];
        }
        if (isset($map['userIdCountMap'])) {
            $model->userIdCountMap = $map['userIdCountMap'];
        }
        if (isset($map['userIdStatusMap'])) {
            $model->userIdStatusMap = $map['userIdStatusMap'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }
        if (isset($map['userMap'])) {
            $model->userMap = $map['userMap'];
        }

        return $model;
    }
}
