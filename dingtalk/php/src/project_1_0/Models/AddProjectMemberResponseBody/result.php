<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\AddProjectMemberResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $joined;

    /**
     * @var string
     */
    public $nickname;
    protected $_name = [
        'joined'   => 'joined',
        'nickname' => 'nickname',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->joined) {
            $res['joined'] = $this->joined;
        }
        if (null !== $this->nickname) {
            $res['nickname'] = $this->nickname;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['joined'])) {
            $model->joined = $map['joined'];
        }
        if (isset($map['nickname'])) {
            $model->nickname = $map['nickname'];
        }

        return $model;
    }
}
