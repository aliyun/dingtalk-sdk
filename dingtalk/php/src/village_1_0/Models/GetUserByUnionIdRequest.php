<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUserByUnionIdRequest extends Model
{
    /**
     * @description 真实请求的组织corpId
     *
     * @var string
     */
    public $subCorpId;

    /**
     * @description 人员 id
     *
     * @var string
     */
    public $unionId;

    /**
     * @description 通讯录语言(默认zh_CN另外支持en_US)
     *
     * @var string
     */
    public $language;
    protected $_name = [
        'subCorpId' => 'subCorpId',
        'unionId'   => 'unionId',
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
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserByUnionIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['subCorpId'])) {
            $model->subCorpId = $map['subCorpId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }

        return $model;
    }
}
