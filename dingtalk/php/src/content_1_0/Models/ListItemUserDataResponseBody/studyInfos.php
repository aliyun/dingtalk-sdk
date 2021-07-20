<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\ListItemUserDataResponseBody;

use AlibabaCloud\Tea\Model;

class studyInfos extends Model
{
    /**
     * @description 用户id
     *
     * @var string
     */
    public $uid;

    /**
     * @description 时间持续长度，单位为毫秒
     *
     * @var int
     */
    public $durationMillis;
    protected $_name = [
        'uid'            => 'uid',
        'durationMillis' => 'durationMillis',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->uid) {
            $res['uid'] = $this->uid;
        }
        if (null !== $this->durationMillis) {
            $res['durationMillis'] = $this->durationMillis;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return studyInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['uid'])) {
            $model->uid = $map['uid'];
        }
        if (isset($map['durationMillis'])) {
            $model->durationMillis = $map['durationMillis'];
        }

        return $model;
    }
}
