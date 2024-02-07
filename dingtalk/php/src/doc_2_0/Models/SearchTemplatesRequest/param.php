<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchTemplatesRequest;

use AlibabaCloud\Tea\Model;

class param extends Model
{
    /**
     * @example user_template
     *
     * @var string
     */
    public $belong;

    /**
     * @example searchName
     *
     * @var string
     */
    public $searchName;
    protected $_name = [
        'belong'     => 'belong',
        'searchName' => 'searchName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->belong) {
            $res['belong'] = $this->belong;
        }
        if (null !== $this->searchName) {
            $res['searchName'] = $this->searchName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return param
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['belong'])) {
            $model->belong = $map['belong'];
        }
        if (isset($map['searchName'])) {
            $model->searchName = $map['searchName'];
        }

        return $model;
    }
}
