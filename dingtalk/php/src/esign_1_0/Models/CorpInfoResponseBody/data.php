<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\CorpInfoResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var bool
     */
    public $realName;

    /**
     * @var string
     */
    public $orgRealName;
    protected $_name = [
        'realName'    => 'realName',
        'orgRealName' => 'orgRealName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->realName) {
            $res['realName'] = $this->realName;
        }
        if (null !== $this->orgRealName) {
            $res['orgRealName'] = $this->orgRealName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['realName'])) {
            $model->realName = $map['realName'];
        }
        if (isset($map['orgRealName'])) {
            $model->orgRealName = $map['orgRealName'];
        }

        return $model;
    }
}
