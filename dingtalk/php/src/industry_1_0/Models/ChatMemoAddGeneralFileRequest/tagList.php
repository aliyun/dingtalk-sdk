<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoAddGeneralFileRequest;

use AlibabaCloud\Tea\Model;

class tagList extends Model
{
    /**
     * @example 产品名
     *
     * @var string
     */
    public $tagName;

    /**
     * @var string[]
     */
    public $tagValueList;
    protected $_name = [
        'tagName' => 'tagName',
        'tagValueList' => 'tagValueList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->tagName) {
            $res['tagName'] = $this->tagName;
        }
        if (null !== $this->tagValueList) {
            $res['tagValueList'] = $this->tagValueList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return tagList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['tagName'])) {
            $model->tagName = $map['tagName'];
        }
        if (isset($map['tagValueList'])) {
            if (!empty($map['tagValueList'])) {
                $model->tagValueList = $map['tagValueList'];
            }
        }

        return $model;
    }
}
