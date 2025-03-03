<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ListOperationLogsRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @example 下载:download_file
     *
     * @var string[]
     */
    public $actions;

    /**
     * @example 30
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example next_token
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example union_id
     *
     * @var string
     */
    public $operatorId;

    /**
     * @example 知识库:org_biz_meta
     *
     * @var string[]
     */
    public $scenes;

    /**
     * @example YndMj49yWj95B3qAfGz5pY9d83pmz5aA
     *
     * @var string
     */
    public $subjectId;
    protected $_name = [
        'actions'    => 'actions',
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
        'operatorId' => 'operatorId',
        'scenes'     => 'scenes',
        'subjectId'  => 'subjectId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actions) {
            $res['actions'] = $this->actions;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->scenes) {
            $res['scenes'] = $this->scenes;
        }
        if (null !== $this->subjectId) {
            $res['subjectId'] = $this->subjectId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return option
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actions'])) {
            if (!empty($map['actions'])) {
                $model->actions = $map['actions'];
            }
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['scenes'])) {
            if (!empty($map['scenes'])) {
                $model->scenes = $map['scenes'];
            }
        }
        if (isset($map['subjectId'])) {
            $model->subjectId = $map['subjectId'];
        }

        return $model;
    }
}
