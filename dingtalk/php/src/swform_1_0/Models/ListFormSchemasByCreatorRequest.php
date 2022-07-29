<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListFormSchemasByCreatorRequest extends Model
{
    /**
     * @description 填表类型。0表示通用填表，1表示教育版填表
     *
     * @var int
     */
    public $bizType;

    /**
     * @description 填表创建人userid
     *
     * @var string
     */
    public $creator;

    /**
     * @description 分页大小，最大200
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 分页游标，从0开始。后续取返回结果中nextToken的值。
     *
     * @var int
     */
    public $nextToken;
    protected $_name = [
        'bizType'    => 'bizType',
        'creator'    => 'creator',
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
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
     * @return ListFormSchemasByCreatorRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
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
