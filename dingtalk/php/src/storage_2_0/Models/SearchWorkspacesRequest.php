<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchWorkspacesRequest\option;
use AlibabaCloud\Tea\Model;

class SearchWorkspacesRequest extends Model
{
    /**
     * @example keyword
     *
     * @var string
     */
    public $keyword;

    /**
     * @var option
     */
    public $option;

    /**
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'keyword'    => 'keyword',
        'option'     => 'option',
        'operatorId' => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->keyword) {
            $res['keyword'] = $this->keyword;
        }
        if (null !== $this->option) {
            $res['option'] = null !== $this->option ? $this->option->toMap() : null;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchWorkspacesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['keyword'])) {
            $model->keyword = $map['keyword'];
        }
        if (isset($map['option'])) {
            $model->option = option::fromMap($map['option']);
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
