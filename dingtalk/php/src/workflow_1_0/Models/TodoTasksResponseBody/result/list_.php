<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\TodoTasksResponseBody\result;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @example RUNNING
     *
     * @var string
     */
    public $businessId;

    /**
     * @var bool
     */
    public $canRedirect;

    /**
     * @var int
     */
    public $createTime;

    /**
     * @example act_0001
     *
     * @var string
     */
    public $processCode;

    /**
     * @example Siw2WNVZS4KiUt3tTmaNKg04*****809950
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @example 1234567
     *
     * @var int
     */
    public $taskId;

    /**
     * @example manager001
     *
     * @var string
     */
    public $title;

    /**
     * @example 2022-10-17T15:12Z
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'businessId' => 'businessId',
        'canRedirect' => 'canRedirect',
        'createTime' => 'createTime',
        'processCode' => 'processCode',
        'processInstanceId' => 'processInstanceId',
        'taskId' => 'taskId',
        'title' => 'title',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->businessId) {
            $res['businessId'] = $this->businessId;
        }
        if (null !== $this->canRedirect) {
            $res['canRedirect'] = $this->canRedirect;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['businessId'])) {
            $model->businessId = $map['businessId'];
        }
        if (isset($map['canRedirect'])) {
            $model->canRedirect = $map['canRedirect'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
