<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveWatchUserListResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveWatchUserListResponseBody\result\orgUsesList;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveWatchUserListResponseBody\result\outOrgUserList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 组织内的观看用户列表
     *
     * @var orgUsesList[]
     */
    public $orgUsesList;

    /**
     * @description 组织外的观看用户列表
     *
     * @var outOrgUserList[]
     */
    public $outOrgUserList;
    protected $_name = [
        'orgUsesList'    => 'orgUsesList',
        'outOrgUserList' => 'outOrgUserList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->orgUsesList) {
            $res['orgUsesList'] = [];
            if (null !== $this->orgUsesList && \is_array($this->orgUsesList)) {
                $n = 0;
                foreach ($this->orgUsesList as $item) {
                    $res['orgUsesList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->outOrgUserList) {
            $res['outOrgUserList'] = [];
            if (null !== $this->outOrgUserList && \is_array($this->outOrgUserList)) {
                $n = 0;
                foreach ($this->outOrgUserList as $item) {
                    $res['outOrgUserList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['orgUsesList'])) {
            if (!empty($map['orgUsesList'])) {
                $model->orgUsesList = [];
                $n                  = 0;
                foreach ($map['orgUsesList'] as $item) {
                    $model->orgUsesList[$n++] = null !== $item ? orgUsesList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['outOrgUserList'])) {
            if (!empty($map['outOrgUserList'])) {
                $model->outOrgUserList = [];
                $n                     = 0;
                foreach ($map['outOrgUserList'] as $item) {
                    $model->outOrgUserList[$n++] = null !== $item ? outOrgUserList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
