<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListSubDeptRequest extends Model
{
    /**
     * @example zh_CN
     *
     * @var string
     */
    public $language;

    /**
     * @var string
     */
    public $subCorpId;
    protected $_name = [
        'language'  => 'language',
        'subCorpId' => 'subCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->subCorpId) {
            $res['subCorpId'] = $this->subCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListSubDeptRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['subCorpId'])) {
            $model->subCorpId = $map['subCorpId'];
        }

        return $model;
    }
}
