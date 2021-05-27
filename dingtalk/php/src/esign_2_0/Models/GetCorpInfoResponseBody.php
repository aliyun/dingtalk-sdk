<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetCorpInfoResponseBody extends Model
{
    /**
     * @var string
     */
    public $isRealName;

    /**
     * @var string
     */
    public $orgRealName;
    protected $_name = [
        'isRealName'  => 'isRealName',
        'orgRealName' => 'orgRealName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isRealName) {
            $res['isRealName'] = $this->isRealName;
        }
        if (null !== $this->orgRealName) {
            $res['orgRealName'] = $this->orgRealName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCorpInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isRealName'])) {
            $model->isRealName = $map['isRealName'];
        }
        if (isset($map['orgRealName'])) {
            $model->orgRealName = $map['orgRealName'];
        }

        return $model;
    }
}
