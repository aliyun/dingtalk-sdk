<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\QueryReportDetailResponseBody\content;
use AlibabaCloud\Tea\Model;

class QueryReportDetailResponseBody extends Model
{
    /**
     * @var content[]
     */
    public $content;

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
     * @example 部门1
     *
     * @var string
     */
    public $deptName;

    /**
     * @example 1507564800000
     *
     * @var int
     */
    public $modifiedTime;

    /**
     * @example 这是备注
     *
     * @var string
     */
    public $remark;

    /**
     * @example 18XXXX
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
        'content'      => 'content',
        'createTime'   => 'createTime',
        'creatorId'    => 'creatorId',
        'creatorName'  => 'creatorName',
        'deptName'     => 'deptName',
        'modifiedTime' => 'modifiedTime',
        'remark'       => 'remark',
        'reportId'     => 'reportId',
        'templateName' => 'templateName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = [];
            if (null !== $this->content && \is_array($this->content)) {
                $n = 0;
                foreach ($this->content as $item) {
                    $res['content'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->creatorName) {
            $res['creatorName'] = $this->creatorName;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->modifiedTime) {
            $res['modifiedTime'] = $this->modifiedTime;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
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
     * @return QueryReportDetailResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            if (!empty($map['content'])) {
                $model->content = [];
                $n              = 0;
                foreach ($map['content'] as $item) {
                    $model->content[$n++] = null !== $item ? content::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['creatorName'])) {
            $model->creatorName = $map['creatorName'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['modifiedTime'])) {
            $model->modifiedTime = $map['modifiedTime'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
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
