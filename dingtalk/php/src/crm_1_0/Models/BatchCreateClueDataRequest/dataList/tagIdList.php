<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchCreateClueDataRequest\dataList;

use AlibabaCloud\Tea\Model;

class tagIdList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $tagId;

    /**
     * @var string
     */
    public $tagName;
    protected $_name = [
        'tagId' => 'tagId',
        'tagName' => 'tagName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->tagId) {
            $res['tagId'] = $this->tagId;
        }
        if (null !== $this->tagName) {
            $res['tagName'] = $this->tagName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return tagIdList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['tagId'])) {
            $model->tagId = $map['tagId'];
        }
        if (isset($map['tagName'])) {
            $model->tagName = $map['tagName'];
        }

        return $model;
    }
}
