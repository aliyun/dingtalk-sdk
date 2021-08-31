<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDeptRequest extends Model
{
    /**
     * @description 下属组织的组织ID，比如下属镇、村的corpId
     *
     * @var string
     */
    public $subCorpId;

    /**
     * @description 通讯录语言(默认zh_CN另外支持en_US)
     *
     * @var string
     */
    public $language;
    protected $_name = [
        'subCorpId' => 'subCorpId',
        'language'  => 'language',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->subCorpId) {
            $res['subCorpId'] = $this->subCorpId;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDeptRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['subCorpId'])) {
            $model->subCorpId = $map['subCorpId'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }

        return $model;
    }
}
