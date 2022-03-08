<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListSeniorSettingsResponseBody\seniorWhiteList;
use AlibabaCloud\Tea\Model;

class ListSeniorSettingsResponseBody extends Model
{
    /**
     * @var string[]
     */
    public $protectScenes;

    /**
     * @description Id of the request
     *
     * @var string
     */
    public $seniorStaffId;

    /**
     * @var seniorWhiteList[]
     */
    public $seniorWhiteList;
    protected $_name = [
        'protectScenes'   => 'protectScenes',
        'seniorStaffId'   => 'seniorStaffId',
        'seniorWhiteList' => 'seniorWhiteList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->protectScenes) {
            $res['protectScenes'] = $this->protectScenes;
        }
        if (null !== $this->seniorStaffId) {
            $res['seniorStaffId'] = $this->seniorStaffId;
        }
        if (null !== $this->seniorWhiteList) {
            $res['seniorWhiteList'] = [];
            if (null !== $this->seniorWhiteList && \is_array($this->seniorWhiteList)) {
                $n = 0;
                foreach ($this->seniorWhiteList as $item) {
                    $res['seniorWhiteList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListSeniorSettingsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['protectScenes'])) {
            if (!empty($map['protectScenes'])) {
                $model->protectScenes = $map['protectScenes'];
            }
        }
        if (isset($map['seniorStaffId'])) {
            $model->seniorStaffId = $map['seniorStaffId'];
        }
        if (isset($map['seniorWhiteList'])) {
            if (!empty($map['seniorWhiteList'])) {
                $model->seniorWhiteList = [];
                $n                      = 0;
                foreach ($map['seniorWhiteList'] as $item) {
                    $model->seniorWhiteList[$n++] = null !== $item ? seniorWhiteList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
