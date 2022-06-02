<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryInstancesByMultiConditionsRequest\sortFields;
use AlibabaCloud\Tea\Model;

class QueryInstancesByMultiConditionsRequest extends Model
{
    /**
     * @description 表单CODE
     *
     * @var string
     */
    public $formCode;

    /**
     * @description 分页大小
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 游标位置
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 检索条件
     *
     * @var string
     */
    public $searchFields;

    /**
     * @description 排序条件
     *
     * @var sortFields[]
     */
    public $sortFields;
    protected $_name = [
        'formCode'     => 'formCode',
        'maxResults'   => 'maxResults',
        'nextToken'    => 'nextToken',
        'openTeamId'   => 'openTeamId',
        'searchFields' => 'searchFields',
        'sortFields'   => 'sortFields',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->searchFields) {
            $res['searchFields'] = $this->searchFields;
        }
        if (null !== $this->sortFields) {
            $res['sortFields'] = [];
            if (null !== $this->sortFields && \is_array($this->sortFields)) {
                $n = 0;
                foreach ($this->sortFields as $item) {
                    $res['sortFields'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryInstancesByMultiConditionsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['searchFields'])) {
            $model->searchFields = $map['searchFields'];
        }
        if (isset($map['sortFields'])) {
            if (!empty($map['sortFields'])) {
                $model->sortFields = [];
                $n                 = 0;
                foreach ($map['sortFields'] as $item) {
                    $model->sortFields[$n++] = null !== $item ? sortFields::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
