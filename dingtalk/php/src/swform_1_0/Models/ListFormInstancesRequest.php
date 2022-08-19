<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListFormInstancesRequest extends Model
{
    /**
     * @description 时间，必须是YYYY-MM-DD的格式。循环填表才需要传这个参数。
     *
     * @var string
     */
    public $actionDate;

    /**
     * @description 填表类型。0表示通用填表，1表示教育版填表
     *
     * @var int
     */
    public $bizType;

    /**
     * @description 分页大小，最大100。
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 分页起始，从0开始。当返回结果中hasMore为false时，表示没有下一页了。否则取返回结果中nextToken的值作为下一次请求的offset。
     *
     * @var int
     */
    public $nextToken;
    protected $_name = [
        'actionDate' => 'actionDate',
        'bizType'    => 'bizType',
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionDate) {
            $res['actionDate'] = $this->actionDate;
        }
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListFormInstancesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionDate'])) {
            $model->actionDate = $map['actionDate'];
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
