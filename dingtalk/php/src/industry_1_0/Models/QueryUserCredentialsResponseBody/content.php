<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserCredentialsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserCredentialsResponseBody\content\credentialList;
use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 证书列表
     *
     * @var credentialList[]
     */
    public $credentialList;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'credentialList' => 'credentialList',
        'userId'         => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->credentialList) {
            $res['credentialList'] = [];
            if (null !== $this->credentialList && \is_array($this->credentialList)) {
                $n = 0;
                foreach ($this->credentialList as $item) {
                    $res['credentialList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['credentialList'])) {
            if (!empty($map['credentialList'])) {
                $model->credentialList = [];
                $n                     = 0;
                foreach ($map['credentialList'] as $item) {
                    $model->credentialList[$n++] = null !== $item ? credentialList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
