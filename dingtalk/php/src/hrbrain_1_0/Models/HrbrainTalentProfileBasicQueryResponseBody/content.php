<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainTalentProfileBasicQueryResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainTalentProfileBasicQueryResponseBody\content\profileBaseInfoList;
use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @var profileBaseInfoList[]
     */
    public $profileBaseInfoList;
    protected $_name = [
        'profileBaseInfoList' => 'profileBaseInfoList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->profileBaseInfoList) {
            $res['profileBaseInfoList'] = [];
            if (null !== $this->profileBaseInfoList && \is_array($this->profileBaseInfoList)) {
                $n = 0;
                foreach ($this->profileBaseInfoList as $item) {
                    $res['profileBaseInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['profileBaseInfoList'])) {
            if (!empty($map['profileBaseInfoList'])) {
                $model->profileBaseInfoList = [];
                $n = 0;
                foreach ($map['profileBaseInfoList'] as $item) {
                    $model->profileBaseInfoList[$n++] = null !== $item ? profileBaseInfoList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
