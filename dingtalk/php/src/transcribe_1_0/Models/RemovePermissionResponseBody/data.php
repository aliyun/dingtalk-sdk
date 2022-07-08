<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0\Models\RemovePermissionResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string[]
     */
    public $failNameList;
    protected $_name = [
        'failNameList' => 'failNameList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->failNameList) {
            $res['failNameList'] = $this->failNameList;
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
        if (isset($map['failNameList'])) {
            if (!empty($map['failNameList'])) {
                $model->failNameList = $map['failNameList'];
            }
        }

        return $model;
    }
}
