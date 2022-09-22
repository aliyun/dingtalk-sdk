<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListTemplateRequest extends Model
{
    /**
     * @description 查询模版数量
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 翻页token
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 操作用户unionId
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description 模版类型
     *
     * @var string
     */
    public $templateType;

    /**
     * @description 知识库id。
     *
     * @var string
     */
    public $workspaceId;
    protected $_name = [
        'maxResults'   => 'maxResults',
        'nextToken'    => 'nextToken',
        'operatorId'   => 'operatorId',
        'templateType' => 'templateType',
        'workspaceId'  => 'workspaceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->templateType) {
            $res['templateType'] = $this->templateType;
        }
        if (null !== $this->workspaceId) {
            $res['workspaceId'] = $this->workspaceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListTemplateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['templateType'])) {
            $model->templateType = $map['templateType'];
        }
        if (isset($map['workspaceId'])) {
            $model->workspaceId = $map['workspaceId'];
        }

        return $model;
    }
}
