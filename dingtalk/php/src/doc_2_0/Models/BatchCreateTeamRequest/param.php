<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\BatchCreateTeamRequest;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\BatchCreateTeamRequest\param\createTeamParamList;
use AlibabaCloud\Tea\Model;

class param extends Model
{
    /**
     * @var createTeamParamList[]
     */
    public $createTeamParamList;
    protected $_name = [
        'createTeamParamList' => 'createTeamParamList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTeamParamList) {
            $res['createTeamParamList'] = [];
            if (null !== $this->createTeamParamList && \is_array($this->createTeamParamList)) {
                $n = 0;
                foreach ($this->createTeamParamList as $item) {
                    $res['createTeamParamList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return param
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTeamParamList'])) {
            if (!empty($map['createTeamParamList'])) {
                $model->createTeamParamList = [];
                $n                          = 0;
                foreach ($map['createTeamParamList'] as $item) {
                    $model->createTeamParamList[$n++] = null !== $item ? createTeamParamList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
