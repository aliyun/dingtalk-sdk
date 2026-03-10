<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryOrderConvertResultResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryOrderConvertResultResponseBody\result\items\outputInfo;
use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @var string
     */
    public $corpId;

    /**
     * @var int
     */
    public $createTime;

    /**
     * @var string
     */
    public $creatorName;

    /**
     * @var outputInfo
     */
    public $outputInfo;

    /**
     * @var string
     */
    public $status;

    /**
     * @var string
     */
    public $taskBizId;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'corpId' => 'corpId',
        'createTime' => 'createTime',
        'creatorName' => 'creatorName',
        'outputInfo' => 'outputInfo',
        'status' => 'status',
        'taskBizId' => 'taskBizId',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creatorName) {
            $res['creatorName'] = $this->creatorName;
        }
        if (null !== $this->outputInfo) {
            $res['outputInfo'] = null !== $this->outputInfo ? $this->outputInfo->toMap() : null;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->taskBizId) {
            $res['taskBizId'] = $this->taskBizId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creatorName'])) {
            $model->creatorName = $map['creatorName'];
        }
        if (isset($map['outputInfo'])) {
            $model->outputInfo = outputInfo::fromMap($map['outputInfo']);
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['taskBizId'])) {
            $model->taskBizId = $map['taskBizId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
