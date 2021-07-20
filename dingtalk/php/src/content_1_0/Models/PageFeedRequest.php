<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models;

use AlibabaCloud\Tea\Model;

class PageFeedRequest extends Model
{
    /**
     * @description 分页参数：起始位置，初始值应为0，后续传入返回值中的nextCursor字段中的值
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 分页参数：页面展示数量
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 内容Id，如果传入该参数，表示仅筛选内容Id出现在本列表中的内容
     *
     * @var string[]
     */
    public $body;

    /**
     * @description 入驻账号Id(请联系钉钉接口同学获取)
     *
     * @var string
     */
    public $mcnId;
    protected $_name = [
        'nextToken'  => 'nextToken',
        'maxResults' => 'maxResults',
        'body'       => 'body',
        'mcnId'      => 'mcnId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->body) {
            $res['body'] = $this->body;
        }
        if (null !== $this->mcnId) {
            $res['mcnId'] = $this->mcnId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PageFeedRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['body'])) {
            if (!empty($map['body'])) {
                $model->body = $map['body'];
            }
        }
        if (isset($map['mcnId'])) {
            $model->mcnId = $map['mcnId'];
        }

        return $model;
    }
}
