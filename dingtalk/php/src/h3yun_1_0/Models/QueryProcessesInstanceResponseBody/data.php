<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\QueryProcessesInstanceResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\QueryProcessesInstanceResponseBody\data\originator;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example D000183D000185
     *
     * @var string
     */
    public $appCode;

    /**
     * @example 006f870b-4d1c-4cd0-85b3-2e866798e947
     *
     * @var string
     */
    public $bizObjectId;

    /**
     * @example 2021-11-19 19:36:54
     *
     * @var string
     */
    public $createdTimeGMT;

    /**
     * @example null
     *
     * @var string
     */
    public $dingTalkProcessId;

    /**
     * @example null
     *
     * @var string
     */
    public $finishTimeGMT;

    /**
     * @var originator
     */
    public $originator;

    /**
     * @example 报销管理
     *
     * @var string
     */
    public $processDisplayName;

    /**
     * @example 3d0ad4a4-d7d5-4196-9f2c-3ed246f2b713
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @example 3
     *
     * @var int
     */
    public $processVersion;

    /**
     * @example D0001833abb0fb61524487eb01848207bc89b47
     *
     * @var string
     */
    public $schemaCode;

    /**
     * @example 2021-11-19 19:36:54
     *
     * @var string
     */
    public $startTimeGMT;

    /**
     * @example Running
     *
     * @var string
     */
    public $state;
    protected $_name = [
        'appCode'            => 'appCode',
        'bizObjectId'        => 'bizObjectId',
        'createdTimeGMT'     => 'createdTimeGMT',
        'dingTalkProcessId'  => 'dingTalkProcessId',
        'finishTimeGMT'      => 'finishTimeGMT',
        'originator'         => 'originator',
        'processDisplayName' => 'processDisplayName',
        'processInstanceId'  => 'processInstanceId',
        'processVersion'     => 'processVersion',
        'schemaCode'         => 'schemaCode',
        'startTimeGMT'       => 'startTimeGMT',
        'state'              => 'state',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appCode) {
            $res['appCode'] = $this->appCode;
        }
        if (null !== $this->bizObjectId) {
            $res['bizObjectId'] = $this->bizObjectId;
        }
        if (null !== $this->createdTimeGMT) {
            $res['createdTimeGMT'] = $this->createdTimeGMT;
        }
        if (null !== $this->dingTalkProcessId) {
            $res['dingTalkProcessId'] = $this->dingTalkProcessId;
        }
        if (null !== $this->finishTimeGMT) {
            $res['finishTimeGMT'] = $this->finishTimeGMT;
        }
        if (null !== $this->originator) {
            $res['originator'] = null !== $this->originator ? $this->originator->toMap() : null;
        }
        if (null !== $this->processDisplayName) {
            $res['processDisplayName'] = $this->processDisplayName;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->processVersion) {
            $res['processVersion'] = $this->processVersion;
        }
        if (null !== $this->schemaCode) {
            $res['schemaCode'] = $this->schemaCode;
        }
        if (null !== $this->startTimeGMT) {
            $res['startTimeGMT'] = $this->startTimeGMT;
        }
        if (null !== $this->state) {
            $res['state'] = $this->state;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appCode'])) {
            $model->appCode = $map['appCode'];
        }
        if (isset($map['bizObjectId'])) {
            $model->bizObjectId = $map['bizObjectId'];
        }
        if (isset($map['createdTimeGMT'])) {
            $model->createdTimeGMT = $map['createdTimeGMT'];
        }
        if (isset($map['dingTalkProcessId'])) {
            $model->dingTalkProcessId = $map['dingTalkProcessId'];
        }
        if (isset($map['finishTimeGMT'])) {
            $model->finishTimeGMT = $map['finishTimeGMT'];
        }
        if (isset($map['originator'])) {
            $model->originator = originator::fromMap($map['originator']);
        }
        if (isset($map['processDisplayName'])) {
            $model->processDisplayName = $map['processDisplayName'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['processVersion'])) {
            $model->processVersion = $map['processVersion'];
        }
        if (isset($map['schemaCode'])) {
            $model->schemaCode = $map['schemaCode'];
        }
        if (isset($map['startTimeGMT'])) {
            $model->startTimeGMT = $map['startTimeGMT'];
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }

        return $model;
    }
}
