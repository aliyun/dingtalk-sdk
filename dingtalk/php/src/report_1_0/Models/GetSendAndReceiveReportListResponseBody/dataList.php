<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\GetSendAndReceiveReportListResponseBody;

use AlibabaCloud\Tea\Model;

class dataList extends Model
{
    /**
     * @example 1507564800000
     *
     * @var int
     */
    public $createTime;

    /**
     * @example user123
     *
     * @var string
     */
    public $creatorId;

    /**
     * @example 张三
     *
     * @var string
     */
    public $creatorName;

    /**
     * @example 1507564800000
     *
     * @var int
     */
    public $modifiedTime;

    /**
     * @example xxxxxx
     *
     * @var string
     */
    public $reportId;

    /**
     * @example 日报
     *
     * @var string
     */
    public $templateName;
    protected $_name = [
        'createTime' => 'createTime',
        'creatorId' => 'creatorId',
        'creatorName' => 'creatorName',
        'modifiedTime' => 'modifiedTime',
        'reportId' => 'reportId',
        'templateName' => 'templateName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->creatorName) {
            $res['creatorName'] = $this->creatorName;
        }
        if (null !== $this->modifiedTime) {
            $res['modifiedTime'] = $this->modifiedTime;
        }
        if (null !== $this->reportId) {
            $res['reportId'] = $this->reportId;
        }
        if (null !== $this->templateName) {
            $res['templateName'] = $this->templateName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dataList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['creatorName'])) {
            $model->creatorName = $map['creatorName'];
        }
        if (isset($map['modifiedTime'])) {
            $model->modifiedTime = $map['modifiedTime'];
        }
        if (isset($map['reportId'])) {
            $model->reportId = $map['reportId'];
        }
        if (isset($map['templateName'])) {
            $model->templateName = $map['templateName'];
        }

        return $model;
    }
}
